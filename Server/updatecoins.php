<?php
$con=mysqli_connect('localhost','phpmyadmin','77021002','gamedb');

if(mysqli_connect_errno())
{
	echo "1: Connection failed";
	exit();
}

$username = $_POST["username"];
$coins = $_POST["coins"];

$updatequery = "UPDATE accounts SET coins='$coins' WHERE username ='$username'";
mysqli_query($con,$updatequery) or die("5:Insert Player coins failed");

echo "0";






 ?>
