<?php
$con=mysqli_connect('localhost','phpmyadmin','77021002','gamedb');

if(mysqli_connect_errno())
{
	echo "1: Connection failed";
	exit();
}

$userid = $_POST["userid"];
$itemid = $_POST["itemid"];

$updatequery = "INSERT INTO `usersitems`(`userID`, `itemID`) VALUES ('$userid','$itemid')";
mysqli_query($con,$updatequery) or die("8:Equip item failed");

echo "0";






 ?>
