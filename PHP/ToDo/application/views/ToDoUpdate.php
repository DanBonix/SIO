<!DOCTYPE html>
<html lang="fr">
    <head>
        <meta charset="utf-8">
        <title><?php echo $title ?></title>
        <style>
            table{text-align: center; margin: auto;}
            td{font-variant: small-caps; padding: 15px;}
            h1{text-align: center};
            .valider{margin: auto;}
        </style>
    </head>

<h1>Modifier une tâche</h1>

<table>
<?php 

    echo validation_errors();
    
    echo form_open(base_url('ToDo/modifier/'.$id));
    
    echo "<tr><td>".form_label('Ordre', 'ordre')."</td><td>";
    echo form_input('ordre', set_value('ordre',$ordre))."</td></tr>";
    
    echo "<tr><td>".form_label('Tâche', 'task')."</td><td>";
    echo form_input('task', set_value('task',$task))."</td></tr>";
    
    echo "<div class=\"valider\"><tr><td>".form_submit('Modifier', 'Modifier')."</td></tr></div>";
    
    echo form_close();
?>
</table>