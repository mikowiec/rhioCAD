#include "toptoolsview.h"
#include "ui_toptoolsview.h"

TopToolsView::TopToolsView(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::TopToolsView)
{
    ui->setupUi(this);

    _qmlView = new QDeclarativeView();
}

TopToolsView::~TopToolsView()
{
    delete _qmlView;
    delete ui;
}
