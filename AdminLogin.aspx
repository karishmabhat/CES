<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="AdminLogin.aspx.cs" Inherits="CES.AdminLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="row justify-content-center">

<div class="col-md-4 admin">

<div class="card shadow ">

<div class="card-header bg-danger text-white text-center">

Admin Login

</div>

<div class="card-body">

Username

<asp:TextBox ID="txtuser" runat="server" CssClass="form-control"></asp:TextBox>

<br>

Password

<asp:TextBox ID="txtpass" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>

<br>

<asp:Button ID="btnlogin" runat="server" OnClick="btnlogin_Click" Text="Login" CssClass="btn btn-danger w-100"/>

</div>

</div>

</div>

</div>

</asp:Content>
