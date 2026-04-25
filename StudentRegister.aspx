<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="StudentRegister.aspx.cs" Inherits="CES.StudentRegister" %> <asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="row">

<div class="col-md-6 register-img"></div>

<div class="col-md-6 d-flex align-items-center">

<div class="col-md-8 mx-auto">

<div class="card shadow">

<div class="card-header bg-primary text-white text-center">
Student Registration
</div>

<div class="card-body">

Name
<asp:TextBox ID="txtname" runat="server" CssClass="form-control"></asp:TextBox>

<br>

Email
<asp:TextBox ID="txtemail" runat="server" CssClass="form-control"></asp:TextBox>

<br>

Password
<asp:TextBox ID="txtpass" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>

<br>

<asp:Button ID="btnregister" runat="server" Text="Register" CssClass="btn btn-success w-100" OnClick="btnregister_Click1"/>

</div>

</div>

</div>

</div>

</div>

</asp:Content>