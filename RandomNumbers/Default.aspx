<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RandomNumbers._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript">
        function ValidateInput() {
            var regex = /^\d+$/;
            var id = GetClientID("txtInputNumber");
            var txtName = document.getElementById(id);

            if (regex.test(txtName.value)) {
                return true;
            }
            else {
                $("#errorMsg").text("Enter valid number");
                $(".output").css("display", "none");
                return false;
            }
        }
        function GetClientID(asp_net_id) {
            return $("[id$=" + asp_net_id + "]").attr("id");
        };
    </script>
    <div class="content">
        <div class="input">
            <asp:TextBox ID="txtInputNumber" runat="server" Width="100" CssClass="input-box"></asp:TextBox>
            <asp:Button ID="btnSet" runat="server" Text="Set" OnClientClick="return ValidateInput();" />
            <div id="errorMsg"></div>
        </div>
        <div class="output">
            <asp:Repeater ID="rNumbers" runat="server">
                <HeaderTemplate>
                    <ul>
                </HeaderTemplate>

                <ItemTemplate>

                    <li><span><%# Container.DataItem %></span></li>
                </ItemTemplate>

                <FooterTemplate></ul></FooterTemplate>
            </asp:Repeater>
        </div>
    </div>

</asp:Content>
