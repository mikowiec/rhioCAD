#ifndef SHELLWINDOW_H
#define SHELLWINDOW_H

#include <QMainWindow>

namespace Ui {
    class ShellWindow;
}

class ShellWindow : public QMainWindow
{
    Q_OBJECT

public:
    explicit ShellWindow(QWidget *parent = 0);
    ~ShellWindow();

private:
    Ui::ShellWindow *ui;
};

#endif // SHELLWINDOW_H
