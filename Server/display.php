<?php
// Send variables for the MySQL database class.
//Change User,PW and yourDBname
$con = mysqli_connect('localhost','phpmyadmin','77021002','gamedb') or die('Could not connect: ' . mysqli_error());

$query = "SELECT * FROM `accounts` ORDER by `coins` DESC LIMIT 10";
$result = mysqli_query($con,$query) or die('Query failed: ' . mysqli_error());

$num_results = mysqli_num_rows($result);


for($i = 0; $i < $num_results; $i++)
{
    $row = mysqli_fetch_array($result);
    echo $row['username'] . ";" . $row['coins'] . ";";
}

/*
 * ORIGINAL:
for($i = 0; $i < $num_results; $i++)
{
    $row = mysql_fetch_array($result);
    echo $row['name'] . "\t" . $row['score'] . "\n";
}
______

$encode = array();
$i = 1;
while($row = mysql_fetch_assoc($result)) {
    $encode[$row['id']][] = $row['score'];
    $encode[$row['id']][] = $row['name'];
   // $encode[$row['id']][$i] = $row['name'];
    $i++;
}

echo json_encode($encode);
*/
?>