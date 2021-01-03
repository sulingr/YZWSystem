# 研招网系统
## 安装说明
代码在Master分支<br/>
原先打算DBFirst直接写的，但是之前创的数据库范式有不太方便的地方，所有改成了CFFirst模式<br/>
下载后，更改根目录Web.Config的YZWModels连接串。（不会可以不改一般也行或者直接在数据库管理器中查看数据库连接串）<br/>
接着在管理器控制台依次输入<br/>
enable-migrations<br/>
update-database<br/>
当显示了Running Seed method后代表着数据库安装成功了。<br/>
可以修改代码了。<br/>
## 内容要求
Models层：已完成√<br/>
重写了一部分代码，数据库有所更改，删掉了Student表 <br/>
DAL层：已完成√<br/>
采用了泛型处理，基本没有要动的了，DTO层不写了，DTO逻辑放BLL层写<br/>
BLL层：赶工中...<br/>
BLL层不用依赖注入了，用接口来控制，放同一目录。<br/>
UI层：<br/>
Controller：还未开始..<br/>
Views：还未开始..<br/>

