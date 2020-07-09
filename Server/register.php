<?php
$con=mysqli_connect('localhost','phpmyadmin','77021002','gamedb');

if(mysqli_connect_errno())
{
	echo "1: Connection failed";
	exit();
}

$username = $_POST["username"];
$password = $_POST["password"];

$namecheckquery = "SELECT username FROM accounts WHERE username ='$username'";

$namecheck = mysqli_query($con,$namecheckquery) or die ("2:Name check query failed");
if(mysqli_num_rows($namecheck)>0)
{
	echo "3: Name Already Exists";//error code #5 number of names matching !=1
	exit();	
}

//Add user to the table

$loginhash = md5($password);
$insertuserquery="INSERT INTO accounts (username,password,coins) VALUES('".$username."','".$loginhash."','0');";
mysqli_query($con,$insertuserquery) or die("4:Insert Player query failed");

echo "0";



 ?>
