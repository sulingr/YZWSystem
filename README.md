#研招网系统
## 安装说明
原先打算DBFirst直接写的，但是之前创的数据库范式有不太方便的地方，所有改成了CFFirst模式
下载后，更改根目录Web.Config的YZWModels连接串。（不会可以不改一般也行或者直接在数据库管理器中查看数据库连接串）
接着在管理器控制台依次输入
enable-migrations
update-database
当显示了Running Seed method后代表着数据库安装成功了。
可以修改代码了。
## 内容要求
Models层：已完成√
DAL层：已完成√
BLL层：赶工中...
Controller：还未开始..
Views：还未开始..

