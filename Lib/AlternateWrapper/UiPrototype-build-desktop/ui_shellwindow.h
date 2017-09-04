/********************************************************************************
** Form generated from reading UI file 'shellwindow.ui'
**
** Created: Tue May 10 17:49:03 2011
**      by: Qt User Interface Compiler version 4.7.3
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_SHELLWINDOW_H
#define UI_SHELLWINDOW_H

#include <QtCore/QVariant>
#include <QtGui/QAction>
#include <QtGui/QApplication>
#include <QtGui/QButtonGroup>
#include <QtGui/QHeaderView>
#include <QtGui/QMainWindow>
#include <QtGui/QMenuBar>
#include <QtGui/QVBoxLayout>
#include <QtGui/QWidget>

QT_BEGIN_NAMESPACE

class Ui_ShellWindow
{
public:
    QWidget *centralWidget;
    QWidget *verticalWidget;
    QVBoxLayout *verticalLayout;
    QMenuBar *menuBar;

    void setupUi(QMainWindow *ShellWindow)
    {
        if (ShellWindow->objectName().isEmpty())
            ShellWindow->setObjectName(QString::fromUtf8("ShellWindow"));
        ShellWindow->resize(400, 300);
        centralWidget = new QWidget(ShellWindow);
        centralWidget->setObjectName(QString::fromUtf8("centralWidget"));
        verticalWidget = new QWidget(centralWidget);
        verticalWidget->setObjectName(QString::fromUtf8("verticalWidget"));
        verticalWidget->setGeometry(QRect(10, 10, 371, 251));
        QSizePolicy sizePolicy(QSizePolicy::Maximum, QSizePolicy::Maximum);
        sizePolicy.setHorizontalStretch(0);
        sizePolicy.setVerticalStretch(0);
        sizePolicy.setHeightForWidth(verticalWidget->sizePolicy().hasHeightForWidth());
        verticalWidget->setSizePolicy(sizePolicy);
        verticalLayout = new QVBoxLayout(verticalWidget);
        verticalLayout->setSpacing(6);
        verticalLayout->setContentsMargins(11, 11, 11, 11);
        verticalLayout->setObjectName(QString::fromUtf8("verticalLayout"));
        ShellWindow->setCentralWidget(centralWidget);
        menuBar = new QMenuBar(ShellWindow);
        menuBar->setObjectName(QString::fromUtf8("menuBar"));
        menuBar->setGeometry(QRect(0, 0, 400, 20));
        ShellWindow->setMenuBar(menuBar);

        retranslateUi(ShellWindow);

        QMetaObject::connectSlotsByName(ShellWindow);
    } // setupUi

    void retranslateUi(QMainWindow *ShellWindow)
    {
        ShellWindow->setWindowTitle(QApplication::translate("ShellWindow", "ShellWindow", 0, QApplication::UnicodeUTF8));
    } // retranslateUi

};

namespace Ui {
    class ShellWindow: public Ui_ShellWindow {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_SHELLWINDOW_H
