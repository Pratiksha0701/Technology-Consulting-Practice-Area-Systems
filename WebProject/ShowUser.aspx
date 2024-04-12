<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPannel.Master" AutoEventWireup="true" CodeBehind="ShowUser.aspx.cs" Inherits="WebProject.ShowUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
    search :
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</p>
<p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:TemplateField HeaderText="Name">
                <ItemTemplate>
                    <asp:Label ID="fname" runat="server" Text='<%# Eval("fname") %>'></asp:Label>
                    <asp:Label ID="lname" runat="server" Text='<%# Eval("lname") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="address" HeaderText="Address" />
            <asp:BoundField DataField="contact" HeaderText="Phone" />
            <asp:BoundField DataField="email" HeaderText="Email Address" />
        </Columns>
    </asp:GridView>
</p>
</asp:Content>
