<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeFile="ViewEnrollments.aspx.cs" Inherits="CES.ViewEnrollments" %>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="admin">
<h2 class="text-center mb-4">Student Enrollments</h2>

<asp:GridView ID="GridView1" runat="server"
CssClass="table table-bordered table-striped"
AutoGenerateColumns="true">
</asp:GridView>

<button style="background-color:Blue; border:none;">
<a class="nav-link" href="AddCourse.aspx" style="color:white;">Back</a>
</button>

</div>
</asp:Content>