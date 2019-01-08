<%@ Page Title="主页" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                
            </hgroup>
            <p>
               设备背景颜色表示当前设备运行状态。
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    
     <div id="a1" class="device-model device-ok"> <a href="tightvnc:">A1</a></div>
     <div id="a2" class="device-model device-ok"> <a href="tightvnc:">A2</a></div>
     <div id="a3" class="device-model device-ok"> <a href="tightvnc:">A3</a></div>
     <div id="a4" class="device-model device-ok"> <a href="tightvnc:">A4</a></div>
     <div id="a5" class="device-model device-ok"> <a href="tightvnc:">A5</a></div>
   
    <script>
        $(function () {
            setInterval(updateStatus, 1000);
            function updateStatus() {

                $.ajax({
                    type: 'post',
                    url: 'Webservice1.asmx/GetStatus',
                    async: true,
                    success: function (result) {
                        var labelValue = result.documentElement.innerHTML;
                        for(var i=0;i<5;i++)
                        {
                            var strIdx = i.toString();
                            var divIdx = "#a" + strIdx;
                            if (labelValue.indexOf(strIdx) > -1) {
                                $(divIdx).removeClass("device-ok");
                                $(divIdx).addClass("device-error");
                            } else {
                                $(divIdx).removeClass("device-error");
                                $(divIdx).addClass("device-ok");
                            }
                        }
                    },
                    error: function () {
                        console.log('ERROR!');
                    }})                
            }
        })
    </script>
</asp:Content>
