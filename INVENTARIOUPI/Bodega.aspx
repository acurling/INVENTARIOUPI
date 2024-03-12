<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Bodega.aspx.cs" Inherits="INVENTARIOUPI.Bodega" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>CATALOGO DE BODEGAS</h1>

    <br />
    <div class="container container-table" class="mb-3">
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </div>
    <br />
    <div class="mb-3">
        <br />
        Codigo:
        <asp:TextBox ID="tcodigo" class="form-control" runat="server"></asp:TextBox>
        <br />
        Descripcion:
    <asp:TextBox ID="tdescripcion" class="form-control" runat="server"></asp:TextBox>
    </div>
    <br />
    <div class="mb-3">

        <asp:Button ID="bingresar" CssClass="button button1" runat="server" Text="Ingresar" OnClick="bingresar_Click" />
        <asp:Button ID="beliminar" CssClass="button button2" runat="server" Text="Eliminar" OnClick="beliminar_Click" />
    </div>
</asp:Content>
