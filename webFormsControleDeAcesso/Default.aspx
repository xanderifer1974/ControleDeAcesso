<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="webFormsControleDeAcesso.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="width: 1770px; height: 648px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Menu ID="mnCadastro" runat="server">
            <Items>
                <asp:MenuItem Text="Cadastro" Value="Cadastro">
                    <asp:MenuItem Text="Clientes" Value="Clientes"></asp:MenuItem>
                    <asp:MenuItem Text="Fornecedores" Value="Fornecedores"></asp:MenuItem>
                    <asp:MenuItem Text="Produtos" Value="Produtos"></asp:MenuItem>
                </asp:MenuItem>
            </Items>
        </asp:Menu>
    </form>
</body>
</html>
