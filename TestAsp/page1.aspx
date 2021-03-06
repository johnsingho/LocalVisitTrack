﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page1.aspx.cs" Inherits="TestAsp.page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script
        src="https://code.jquery.com/jquery-3.3.1.min.js"
        integrity="sha256-FgpCb/KJQlLNfOu91ta32o/NMZxltwRo8QtmkMRdAu8="
        crossorigin="anonymous" ></script>

    <style type="text/css">
        .auto-style1 {
            width: 282px;
            height: 127px;
        }
    </style>
    <script>
        /**
        * sysName -- 系统名字，必需
        * modName -- 模块名字，可选
        * loginUser -- 登录用户名，可选
        */
        function VisitTrack(sysName, modName, loginUser) {
            //var sUrl = "http://localhost:55833/VisitTrackService.svc/VisitTrackWeb/Visit";
            var sUrl = "http://dmnnt022:9900/VisitTrackService.svc/VisitTrackWeb/Visit";
            var paras = {
                'sysname': sysName,
                'modname': modName,
                'loginuser': loginUser
            };
            $.ajax({
                url: sUrl,
                data: paras,
                dataType: "jsonp",
                error: function (xhr, status, error) {
                    console.log("Error:" + error);
                }
            });
        }
    </script>
    <script>
        $(function () {
            $("#btnGet").click(function () {
                VisitTrack($("#txt1").val(), $("#txt2").val(), $("#txt3").val());
                VisitTrack('程序一', '模块一', '用户名');
            });
 
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>    
        To get value:<br />
        <input id="txt1" type="text" /><br />
        <br />
        <input id="txt2" type="text" /><br />
        <br />
        <input id="txt3" type="text" /><br />        
        <input id="btnGet" type="button" value="提交" /><br />
    </div>
    </form>
    <hr />
    <textarea id="txtRes" class="auto-style1" name="S1"></textarea>
    <br />
</body>
</html>
