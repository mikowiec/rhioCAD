#include "shellwindow.h"
#include "ui_shellwindow.h"

#include "toptoolsview.h"

ShellWindow::ShellWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::ShellWindow)
{
    ui->setupUi(this);
    setCentralWidget(new TopToolsView());
}

ShellWindow::~ShellWindow()
{
    delete ui;
}
