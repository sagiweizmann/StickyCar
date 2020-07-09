<?php
$con=mysqli_connect('localhost','phpmyadmin','77021002','gamedb');

if(mysqli_connect_errno())
{
	echo "1: Connection failed";
	exit();
}

$user_id = $_POST["id"];


$sql = "SELECT itemID FROM usersitems WHERE userID ='$user_id'";
$res=mysqli_query($con,$sql);
if($res->num_rows > 0)
{
	$rows=array();
	while($row=$res->fetch_assoc()){
		$rows[]=$row;
	}
	echo json_encode($rows);
}else{
	echo "0 results";
}


 ?>
