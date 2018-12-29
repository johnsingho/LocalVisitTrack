<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page1.aspx.cs" Inherits="TestAsp.page1" %>

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
        function RetFunc(dat) {
            alert("success:" + dat);
        }

        $(function () {
            $("#btnGet").click(function () {
                var sUrl = "http://localhost:55833/VisitTrackService.svc/VisitTrackWeb/GetData";
                var paras = {
                    'value': $("#txt1").val()
                };
                //$.getJSON(sUrl+"?callback=?", function (dat) {
                //    alert("success:" + dat);
                //});

                $.ajax({
                    url: sUrl,
                    data: paras,
                    dataType: "jsonp",
                    //jsonpCallback: "RetFunc",
                    crossDomain:true,
                    success: function (data) {
                        alert("success:" + data);
                    },
                    error: function (xhr, status, error) {
                        alert("Error:"+error);
                    }
                });

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
        <input id="btnGet" type="button" value="提交" /><br />
    </div>
    </form>
    <hr />
    <textarea id="txtRes" class="auto-style1" name="S1"></textarea>
    <br />
</body>
</html>
