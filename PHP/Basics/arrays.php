<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php    
        // INDEX ARRAY
        // $students = array("Luqman", "Hanzala", "Ayan", "Huzaifa", "Sami", "Daniyal", "Hussain");
        // echo "<pre>";
        // print_r($students);
        // echo "</pre>";
    
        // foreach($students as $key => $value){
        //     echo "$key: $value <br/>"; 
        // }

        // ASSOCIATIVE ARRAY
        $employee = [
            "Name" => "Abdul Rafay",
            "Age" => 22,
            "JobTitle" => "Software Developer",
            "Experience" => "5 years"
        ];

        // echo $employee["JobTitle"];

        // echo "<pre>";
        // print_r($employee);
        // echo "</pre>";

        // foreach($employee as $key => $value){
        //         echo "$key: $value <br/>"; 
        //     }


        // Multidimentional Array

        // $stdmarks = [
        //     ["Ayan", 80],
        //     ["Hanzala", 95],
        //     ["Luqman", 100],
        //     ["Sami", 100],
        //     ["Waqar", 110],
        //     ["Ayan", 80],
        //     ["Hanzala", 95],
        //     ["Luqman", 100],
        //     ["Sami", 100],
        //     ["Waqar", 110]
        // ]; 

        // echo $stdmarks[2][0];

        //  echo "<pre>";
        // print_r($stdmarks);
        // echo "</pre>";

        // echo "<table border=2 cellspacing=3px>
        // <h1>Students Data Result</h1>
        // <tr bgcolor='yellow'>
        //     <th>StdName</th>
        //     <th>Percentage</th>
        // </tr>";

        // foreach($stdmarks as $key1 => $value1){
        //     echo "<tr>";
        //     foreach($value1 as $key2 => $value2){
        //         echo "<td>$value2</td>";
        //     }
        //     echo "</tr>";
        // }

        // echo "</table>";

        // Multidimentional Associative Array
        $marks = [
            "Luqman" => ["OfficeAutomation" => 95, "BMW" => 88, "PJS" => 92],
            "Sami" => ["OfficeAutomation" => 100, "BMW" => 98, "PJS" => 72],
            "Ayan" => ["OfficeAutomation" => 90, "BMW" => 88, "PJS" => 92],
            "Hanzala" => ["OfficeAutomation" => 89, "BMW" => 100, "PJS" => 92],
            "Daniyal" => ["OfficeAutomation" => 78, "BMW" => 88, "PJS" => 92],
            "Huzaifa" => ["OfficeAutomation" => 70, "BMW" => 100, "PJS" => 92],
            "Uzaifa" => ["OfficeAutomation" => 90, "BMW" => 88, "PJS" => 100]
        ];

        // echo $marks["Daniyal"]["OfficeAutomation"];
    

        echo "<pre>";
        print_r($marks);
        echo "</pre>";


        // NAME || OFF || BMW || PJS

    ?>

</body>
</html>