<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="webFormsControleDeAcesso.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1757px;
            height: 629px;
        }
    </style>
</head>
<body style="width: 1770px; height: 648px">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Menu ID="mnPrincipal" runat="server" BackColor="#E3EAEB" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#666666" Orientation="Horizontal" StaticSubMenuIndent="10px">
                <DynamicHoverStyle BackColor="#666666" ForeColor="White" />
                <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <DynamicMenuStyle BackColor="#E3EAEB" />
                <DynamicSelectedStyle BackColor="#1C5E55" />
                <Items>
                    <asp:MenuItem Text="Cadastro" Value="Cadastro"></asp:MenuItem>
                    <asp:MenuItem Text="Consulta" Value="Consulta"></asp:MenuItem>
                    <asp:MenuItem Text="Movimentação" Value="Movimentação"></asp:MenuItem>
                    <asp:MenuItem Text="Financeiro" Value="Financeiro"></asp:MenuItem>
                    <asp:MenuItem Text="Relatórios" Value="Relatórios"></asp:MenuItem>
                    <asp:MenuItem Text="Usuários" Value="Usuários"></asp:MenuItem>
                    <asp:MenuItem Text="Ferramentas" Value="Ferramentas"></asp:MenuItem>
                </Items>
                <StaticHoverStyle BackColor="#666666" ForeColor="White" />
                <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <StaticSelectedStyle BackColor="#1C5E55" />
            </asp:Menu>
        </div>
    </form>
</body>
</html>
