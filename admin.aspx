<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin.aspx.cs" Inherits="admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>图书管理系统</title>
    <link rel="icon" href="Resources/img/logo.png" type="image/x-icon"/>
    <link href="Resources/css/public.css" rel="stylesheet" type="text/css"/>
    <link href="Resources/css/admin.css" rel="stylesheet" type="text/css"/>
</head>
<body>
    <!--左侧功能选项栏-->
    <div id="left"></div>

    <!--右侧主页面-->
    <div id="right">

        <!--顶部展示框-->
        <div id="top">
            <iframe src="iframe.aspx"></iframe>
        </div>

        <!--底部版权信息-->
        <div id="bottom"></div>
    </div>
</body>
</html>
