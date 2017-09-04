//Copyright (c) 2007-2010, Adolfo Marinucci
//All rights reserved.

//Redistribution and use in source and binary forms, with or without modification, 
//are permitted provided that the following conditions are met:
//
//* Redistributions of source code must retain the above copyright notice, 
//  this list of conditions and the following disclaimer.
//* Redistributions in binary form must reproduce the above copyright notice, 
//  this list of conditions and the following disclaimer in the documentation 
//  and/or other materials provided with the distribution.
//* Neither the name of Adolfo Marinucci nor the names of its contributors may 
//  be used to endorse or promote products derived from this software without 
//  specific prior written permission.
//
//THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" 
//AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
//WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
//IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
//INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, 
//PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) 
//HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, 
//OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, 
//EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE. 

#region Usings

using System.Windows.Input;
using AvalonDock.Properties;

#endregion

namespace AvalonDock
{
    public sealed class DocumentPaneCommands
    {
        private static readonly object syncRoot = new object();


        private static RoutedUICommand closeAllButThisCommand;

        private static RoutedUICommand closeThisCommand;

        private static RoutedUICommand newHTabGroupCommand;

        private static RoutedUICommand newVTabGroupCommand;

        public static RoutedUICommand CloseAllButThis
        {
            get
            {
                lock (syncRoot)
                {
                    if (null == closeAllButThisCommand)
                    {
                        closeAllButThisCommand = new RoutedUICommand(Resources.DocumentPaneCommands_CloseAllButThis,
                                                                     "CloseAllButThis", typeof (DocumentPaneCommands));
                    }
                }
                return closeAllButThisCommand;
            }
        }

        public static RoutedUICommand CloseThis
        {
            get
            {
                lock (syncRoot)
                {
                    if (null == closeThisCommand)
                    {
                        closeThisCommand = new RoutedUICommand(Resources.DocumentPaneCommands_CloseThis, "Close",
                                                               typeof (DocumentPaneCommands));
                    }
                }
                return closeThisCommand;
            }
        }

        public static RoutedUICommand NewHorizontalTabGroup
        {
            get
            {
                lock (syncRoot)
                {
                    if (null == newHTabGroupCommand)
                    {
                        newHTabGroupCommand = new RoutedUICommand(Resources.DocumentPaneCommands_NewHorizontalTabGroup,
                                                                  "NewHorizontalTabGroup", typeof (DocumentPaneCommands));
                    }
                }
                return newHTabGroupCommand;
            }
        }

        public static RoutedUICommand NewVerticalTabGroup
        {
            get
            {
                lock (syncRoot)
                {
                    if (null == newVTabGroupCommand)
                    {
                        newVTabGroupCommand = new RoutedUICommand(Resources.DocumentPaneCommands_NewVerticalTabGroup,
                                                                  "NewVerticalTabGroup", typeof (DocumentPaneCommands));
                    }
                }
                return newVTabGroupCommand;
            }
        }


        //private static RoutedUICommand activateDocument = null;
        //public static RoutedUICommand ActivateDocument
        //{
        //    get
        //    {
        //        lock (syncRoot)
        //        {
        //            if (null == activateDocument)
        //            {
        //                activateDocument = new RoutedUICommand("Activate Document", "ActivateDocuement", typeof(DocumentPaneCommands));
        //            }
        //        }
        //        return activateDocument;
        //    }
        //}

        //#region Activate Document Command
        //public static RoutedCommand ActivateDocumentCommand = new RoutedCommand();

        //public void ExecutedActivateDocumentCommand(object sender,
        //    ExecutedRoutedEventArgs e)
        //{
        //    ManagedContent doc = e.Parameter as ManagedContent;
        //    if (doc != null)
        //    {
        //        doc.Activate();
        //    }
        //}

        //public void CanExecuteActivateDocumentCommand(object sender,
        //    CanExecuteRoutedEventArgs e)
        //{
        //    e.CanExecute = true;
        //}

        //#endregion
    }
}