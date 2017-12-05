<!DOCTYPE html>
<html lang="fr">
    <head>
        <meta charset="utf-8">
        <title><?php echo $title ?></title>
        <style>
            table{text-align: center; margin: auto;}
            td{font-variant: small-caps; padding: 15px;}
            h1{text-align: center};
        </style>
    </head>

<h1>Ajouter une nouvelle tâche</h1>

<table>
<?php

    //echo validation_errors();
    
    echo form_open(base_url('ToDo/ajouter'));
    
    echo "<tr><td>".form_label('Ordre', 'ordre')."</td><td>";
    echo form_input('ordre', set_value('ordre',0))."</td><td>";
    echo form_error('ordre')."</td></tr>";
    
    echo "<tr><td>".form_label('Tâche', 'task')."</td><td>";
    echo form_input('task', set_value('task', 'Saisir nouvelle tâche'))."</td><td>";
    echo form_error('task')."</td></tr>";
    
    echo "<tr><td>".form_submit('Ajouter', 'Ajouter')."</td>";
    echo "<td>".form_submit('index', 'Retour')."</td></tr>";
    
    
    echo form_close();
?>
</table>