<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="MyCourses.aspx.cs" Inherits="CES.MyCourses" %>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="admin">
<h2 class="text-center">My Enrolled Courses</h2>

<asp:GridView ID="GridView1" runat="server"
CssClass="table table-striped table-bordered">
</asp:GridView>

<button style="background-color:Blue; border:none;">
<a class="nav-link" href="EnrollCourse.aspx" style="color:white;">Back</a>
</button>
</div>
</asp:Content>