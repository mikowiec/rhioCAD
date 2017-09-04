#region Usages

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using ApiCommon;

#endregion

namespace ApiGenerators.Forms
{
    public partial class OccTypeFormLookup : Form
    {
        private readonly DataNode _api;
        private readonly Assembly _assembly;
        private string _prefix;

        public OccTypeFormLookup(DataNode api)
        {
            _api = api;
            InitializeComponent();
            _assembly = Assembly.Load("OCWrappers");
            button3.Click += BaseClassSwitch;
        }

        private void TextBox1KeyUp(object sender, KeyEventArgs e)
        {
            timer1.Interval = 400;
            timer1.Stop();
            timer1.Start();
            if (e.KeyCode != Keys.Enter)
                return;
            UpdateMethodList();
        }

        private void UpdateMethodList()
        {
            timer1.Stop();
            var typeName = GetTypeName();
            var type = SearchType(typeName);
            if (type == null)
            {
                return;
            }
            var lastIndex = listBox1.SelectedIndex;
            var onlyConstructors = constructorsCheckBox.Checked;
            listBox1.BeginUpdate();
            listBox1.Items.Clear();
            foreach (var method in type.GetMembers(BindingFlags.DeclaredOnly |
                                                   BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static))
            {
                if (onlyConstructors && method is MethodInfo) continue;
                if (method.Name.StartsWith(_prefix))
                    try
                    {
                        listBox1.Items.Add(method);
                    }
                    catch
                    {
                    }
            }
            listBox1.EndUpdate();
            if (listBox1.Items.Count <= lastIndex) return;
            listBox1.SelectedIndex = lastIndex;
            button3.Visible = type.BaseType != null && !type.BaseType.Equals(typeof (object));
            button3.Tag = type.BaseType;
            if (type.BaseType != null) button3.Text = type.BaseType.Name;
        }

        private void BaseClassSwitch(object sender, EventArgs eventArgs)
        {
            textBox1.Text = ((Type) button3.Tag).Name;
            UpdateMethodList();
            timer1.Stop();
        }

        private string GetTypeName()
        {
            _prefix = string.Empty;
            var typeName = textBox1.Text;
            if (typeName.Contains("."))
            {
                var words = typeName.Split('.');
                typeName = words[0];
                _prefix = words[1];
            }
            //if (!typeName.StartsWith("OC"))
            //    typeName = "OC" + typeName;
            typeName = "OCNaroWrappers." + typeName;
            return typeName;
        }

        private Type SearchType(string typeName)
        {
            var typeList = _assembly.GetTypes();
            Type result = null;
            foreach (var asmType in typeList)
            {
                if (asmType.FullName != typeName)
                    continue;
                result = asmType;
                break;
            }
            if (result != null) return result;
            var foundTypes = new List<Type>();
            foreach (var asmType in typeList)
            {
                if (asmType.FullName == null) continue;
                if (!asmType.FullName.StartsWith(typeName)) continue;
                foundTypes.Add(asmType);
            }
            if (foundTypes.Count == 0) return null;
            if (foundTypes.Count == 1)
            {
                result = foundTypes[0];
                textBox1.Text = result.Name.Remove(0, 2) + ".";
                textBox1.SelectionStart = textBox1.Text.Length;
                return result;
            }

            var items = new List<string>();
            foreach (var foundType in foundTypes)
            {
                items.Add(foundType.Name);
            }
            var comonText = StartCommon(items);
            if (comonText.Length <= 2) return null;
            textBox1.Text = comonText.Remove(0, 2);
            textBox1.SelectionStart = textBox1.Text.Length;
            return null;
        }

        private static string StartCommon(IList<string> items)
        {
            if (items.Count == 0) return string.Empty;
            var startChars = string.Empty;
            var firstItem = items[0];
            var offset = 1;
            while (true)
            {
                if (offset >= firstItem.Length) return startChars;
                var startCommon = firstItem.Substring(0, offset);
                foreach (var item in items)
                {
                    if (!item.StartsWith(startCommon))
                        return startChars;
                }
                startChars = startCommon;
                offset++;
            }
        }

        private void AddNodeToApi()
        {
            if (listBox1.SelectedIndex == -1) return;
            if (listBox1.SelectedItem is MethodInfo)
            {
                AddMethodToApi((MethodInfo) listBox1.SelectedItem);
            }
            else if (listBox1.SelectedItem is ConstructorInfo)
            {
                AddConstructorToApi((ConstructorInfo) listBox1.SelectedItem);
            }
            constructorsCheckBox.Checked = false;
            isMedhodCheckBox.Checked = false;
        }

        private void AddMethodToApi(MethodInfo item)
        {
            var typeName = GetTypeName();
            var type = SearchType(typeName);
            if (type == null)
                return;
            ConstrucsApiGenerators.BuildMethodNode(_api, type, item, isMedhodCheckBox.Checked);
            isMedhodCheckBox.Checked = false;
            SetStatus("Added Method: " + item);
        }

        private void AddConstructorToApi(ConstructorInfo item)
        {
            var typeName = GetTypeName();
            var type = SearchType(typeName);
            if (type == null)
                return;
            ConstrucsApiGenerators.BuildConstructorNode(_api, type, item);
            SetStatus("Added: " + item);
        }

        private void SetStatus(string text)
        {
            statusLabel.Text = text;
        }

        private void ListBox1MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AddNodeToApi();
        }

        private void ListBox1KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;
            AddNodeToApi();
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            AddNodeToApi();
        }

        private void Timer1Tick(object sender, EventArgs e)
        {
            UpdateMethodList();
        }

        private void OccTypeFormLookupActivated(object sender, EventArgs e)
        {
            Opacity = 1.0;
        }

        private void OccTypeFormLookupDeactivate(object sender, EventArgs e)
        {
            Opacity = 0.86;
        }


        public static void RegenWrapper(DataNode api)
        {
            DataNodeLoader.ToFile(api, "..\\..\\OccWrapper.api");
            const string apiGeneratorPath = "..\\..\\..\\" + "ApiToWrapper" + "\\bin\\debug\\";
            if (!Directory.Exists(apiGeneratorPath))
                return;
            var finalLocation = Path.Combine(Directory.GetCurrentDirectory(), apiGeneratorPath);
            var process = new Process
                              {
                                  StartInfo =
                                      {
                                          FileName = "ApiToWrapper.exe",
                                          WorkingDirectory = finalLocation,
                                          WindowStyle = ProcessWindowStyle.Hidden
                                      }
                              };
            process.Start();
        }

        private void Button4Click(object sender, EventArgs e)
        {
            RegenWrapper(_api);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMethodList();
        }
    }
}