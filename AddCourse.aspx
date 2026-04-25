<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeFile="AddCourse.aspx.cs" Inherits="CES.AddCourse" %>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


<h2 class="text-center mb-4">Add New Course</h2>

<div class="row align-items-center">


<div class="col-md-6">

<div class="card shadow-lg border-0">

<div class="card-header bg-success text-white text-center">
 Add Course
</div>

<div class="card-body">

<label>Course Name</label>

<asp:TextBox ID="txtcourse" runat="server" CssClass="form-control"></asp:TextBox>

<br>

<label>Description</label>

<asp:TextBox ID="txtdesc" runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control"></asp:TextBox>

<br>

<div class="d-grid gap-2">

<asp:Button ID="btnadd" runat="server"
Text="➕Add Course"
CssClass="btn btn-success"
OnClick="btnadd_Click" />

<a href="ViewEnrollments.aspx" class="btn btn-primary">
View Enrollments
</a>

</div>

</div>

</div>

</div>


<div class="col-md-6 text-center">

<img src="image/admin.png">

</div>

</div>

</asp:Content>