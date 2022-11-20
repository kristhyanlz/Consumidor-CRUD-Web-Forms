<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Consumidor.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %> Evidencia 4</h2>
    <h3>CRUD</h3>

    <table>
        <tr>
            <th>ID producto</th>
            <th><asp:TextBox ID="txtbox_id" runat="server"></asp:TextBox></th>
        </tr>
        <tr>
            <th>Código producto </th>
            <th><asp:TextBox ID="txtbox_codigo" runat="server"></asp:TextBox></th>
        </tr>
        <tr>
            <th>Nombre</th>
            <th><asp:TextBox ID="txtbox_nombre" runat="server"></asp:TextBox></th>
        </tr>
        <tr>
            <th>Marca</th>
            <th><asp:TextBox ID="txtbox_marca" runat="server"></asp:TextBox></th>
        </tr>
        <tr>
            <th>Descripción</th>
            <th><asp:TextBox ID="txtbox_desc" runat="server"></asp:TextBox></th>
        </tr>
        <tr>
            <th>Precio compra</th>
            <th><asp:TextBox ID="txtbox_compra" runat="server"></asp:TextBox></th>
        </tr>
        <tr>
            <th>Precio venta</th>
            <th><asp:TextBox ID="txtbox_venta" runat="server"></asp:TextBox></th>
        </tr>
        <tr>
            <th>Material</th>
            <th><asp:TextBox ID="txtbox_material" runat="server"></asp:TextBox></th>
        </tr>
    </table>

    <asp:Button ID="btn_insert" runat="server" Text="INSERT" OnClick="btn_insert_Click" />
    <asp:Button ID="btn_select" runat="server" Text="SELECT *" OnClick="btn_select_Click" />
    <asp:Button ID="btn_update" runat="server" Text="UPDATE" OnClick="btn_update_Click" />
    <asp:Button ID="btn_delete" runat="server" Text="DELETE" OnClick="btn_delete_Click" />
    <p></p>
    <p><asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="True"  OnSelectedIndexChanged="GridView1_SelectedIndexChanged"></asp:GridView></p>
    

</asp:Content>