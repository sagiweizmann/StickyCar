<?php
$con=mysqli_connect('localhost','phpmyadmin','77021002','gamedb');

if(mysqli_connect_errno())
{
	echo "1: Connection failed";
	exit();
}

$username = $_POST["username"];
$itemid = $_POST["itemid"];

$updatequery = "UPDATE accounts SET currentskin='$itemid' WHERE username ='$username'";
mysqli_query($con,$updatequery) or die("8:Equip item failed");

echo "0";






 ?>
