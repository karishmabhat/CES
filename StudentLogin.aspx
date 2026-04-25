<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="StudentLogin.aspx.cs" Inherits="CES.StudentLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="row align-items-center">


<div class="col-md-5 mx-auto">

<div class="card shadow">

<div class="card-header bg-success text-white text-center">
Student Login
</div>

<div class="card-body">

Email

<asp:TextBox ID="txtemail" runat="server" CssClass="form-control"></asp:TextBox>

<br>

Password

<asp:TextBox ID="txtpass" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>

<br>

<asp:Button ID="btnlogin" runat="server" Text="Login" CssClass="btn btn-primary w-100" OnClick="btnlogin_Click"/>

</div>

</div>

</div>

<div class="col-md-6 login-img"></div>

</div>
</asp:Content>
