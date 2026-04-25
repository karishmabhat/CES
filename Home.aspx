<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="CES.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!-- HERO SECTION -->

<section class="hero text-center text-white p-5" style="background-image:url('image/banner.jpg'); background-size:cover; background-position:center; min-height:400px;">

<div class="container">

<h1 class="display-4 fw-bold" align="right">Course Enrollment System</h1>

<p class="lead"></p>

<div class="text-end">
<a href="StudentRegister.aspx" class="btn btn-warning btn-lg mt-3">
Start Learning
</a>
</div>

</div>

</section>


<!-- FEATURES SECTION -->

<section class="container mt-5">

<h2 class="text-center mb-4">Our Features</h2>

<div class="row text-center">

<div class="col-md-3">

<img src="image/icon1.png" height="55%" width="50%" >

<h4>Online Enrollment</h4>

<p>Students can easily enroll in courses online.</p>

</div>

<div class="col-md-3">

<img src="image/icon2.png" height="55%" width="50%" >

<h4>Course Management</h4>

<p>Admin can add and manage courses.</p>

</div>

<div class="col-md-3">

<img src="image/icon3.png" height="55%" width="50%" >

<h4>Student Dashboard</h4>

<p>Students can view their enrolled courses.</p>

</div>

<div class="col-md-3">

<img src="image/icon4.png" height="55%" width="50%" >

<h4>Secure Login</h4>

<p>Separate login for students and admin.</p>

</div>

</div>

</section>


<!-- COURSES SECTION -->

<section class="container mt-5">

<h2 class="text-center mb-4">Popular Courses</h2>

<div class="row">

<div class="col-md-4">

<div class="card shadow">

<img src="image/web.png" class="card-img-top">

<div class="card-body text-center">

<h5 class="card-title">Web Development</h5>

<p>Duration: 3 Months</p>

<a href="StudentRegister.aspx" class="btn btn-primary">Enroll</a>

</div>

</div>

</div>


<div class="col-md-4">

<div class="card shadow">

<img src="image/sci.png" class="card-img-top">

<div class="card-body text-center">

<h5 class="card-title">Data Science</h5>

<p>Duration: 4 Months</p>

<a href="StudentRegister.aspx" class="btn btn-primary">Enroll</a>

</div>

</div>

</div>

<div class="col-md-4">

<div class="card shadow">

<img src="image/cloud.png" class="card-img-top">

<div class="card-body text-center">

<h5 class="card-title">Cloud Computing</h5>

<p>Duration: 2 Months</p>

<a href="StudentRegister.aspx" class="btn btn-primary">Enroll</a>

</div>

</div>

</div>

</div>

</section>


<!-- ABOUT SECTION -->

<section class="container mt-5 mb-5">

<div class="row align-items-center">

<div class="col-md-6">

<img src="image/about.png" height="90%" width="90%">

</div>

<div class="col-md-6">

<h2>About Course Enrollment System</h2>

<p>

The Course Enrollment System is a web platform where students can register, explore available courses, and enroll easily online. It simplifies course management for administrators and improves accessibility for students.

</p>

<a href="StudentRegister.aspx" class="btn btn-success">Register Now</a>

</div>

</div>

</section>

</asp:Content>