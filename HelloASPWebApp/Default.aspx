<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HelloASPWebApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Aplikacja Hello Web .NET</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Podaj imię:&nbsp;
            <asp:TextBox ID="TextBoxImie" runat="server"></asp:TextBox>
            <br />
            Podaj nazwisko:&nbsp;
            <asp:TextBox ID="TextBoxNazwisko" runat="server"></asp:TextBox>
            <br />
            Podaj wiek:&nbsp;
            <asp:TextBox ID="TextBoxWiek" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="ButtonOK" runat="server" Text="Button" OnClick="ButtonOK_Click" />
            <br />
            <br />
            <asp:Label ID="LabelKom1" runat="server"></asp:Label>
            <br />
            <asp:Label ID="LabelKom2" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
