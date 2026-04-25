<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="EnrollCourse.aspx.cs" Inherits="CES.EnrollCourse" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<h2 class="text-center mb-4">Available Courses</h2>

<div class="row g-4">

<asp:Repeater ID="RepeaterCourses" runat="server">

<ItemTemplate>

<div class="col-md-4">

<div class="card shadow">

<img src="image/courses.png"
class="card-img-top p-3" style="height:200px;object-fit:contain">

<div class="card-body text-center">

<h5><%# Eval("CourseName") %></h5>

<p><%# Eval("Description") %></p>

<asp:Button runat="server"
Text="Enroll"
CssClass="btn btn-success"
CommandArgument='<%# Eval("CourseID") %>'
OnClick="EnrollCourse_Click" />


</div>

</div>

</div>

</ItemTemplate>

</asp:Repeater>

</div>

<br>

<a href="MyCourses.aspx" class="btn btn-primary">
View My Courses
</a>

</asp:Content>