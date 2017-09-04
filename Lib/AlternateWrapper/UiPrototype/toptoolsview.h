#ifndef TOPTOOLSVIEW_H
#define TOPTOOLSVIEW_H

#include <QWidget>

#include <QDeclarativeView>

namespace Ui {
    class TopToolsView;
}

class TopToolsView : public QWidget
{
    Q_OBJECT

public:
    explicit TopToolsView(QWidget *parent = 0);
    ~TopToolsView();

private:
    Ui::TopToolsView *ui;

    QDeclarativeView* _qmlView;
};

#endif // TOPTOOLSVIEW_H
