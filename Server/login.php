<?php
$con=mysqli_connect('localhost','phpmyadmin','77021002','gamedb');

if(mysqli_connect_errno())
{
	echo "1: Connection failed";
	exit();
}

$username = $_POST["username"];
$password = $_POST["password"];

$namecheckquery = "SELECT id,username,password,coins,currentskin FROM accounts WHERE username ='$username'";

$namecheck = mysqli_query($con,$namecheckquery);
if(mysqli_num_rows($namecheck)!=1)
{
	echo "5: Either no user with name or more than one";//error code #5 number of names matching !=1
	exit();	
}

//Get login info

$existinginfo = mysqli_fetch_assoc($namecheck);
$existingpassword = $existinginfo["password"];

$loginhash = md5($password);

if($loginhash != $existingpassword)
{
	echo "6: Incorrect password";
	exit();
}

echo "0\t" . $existinginfo["coins"];
echo "\t" . $existinginfo["id"];
echo "\t" . $existinginfo["currentskin"];





 ?>
