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
    
    <body>
        <div class="container">
            <h1>Liste de mes travaux</h1>
            <table>
            <th>Tâche</th><th>Ordre</th><th>Complétée</th>
            <?php foreach($todos as $todo): ?>
                <tr>
                    <td>
                        <?php
                            $complete = "Non";
                        
                            if($todo['completed'] == 1)
                            {
                                $complete = "Oui";
                            }
                        ?>
                        
                        <?php
                            if($complete != "Oui")
                            {
                                echo $todo['task']."</td><td>".$todo['ordre']."</td><td>".$complete."</td><td>";
                        ?>
                                <a href="<?php echo base_url('ToDo/fait/'.$todo['id']); ?>">Fait</a>
                        <?php
                            }
                            else
                            {
                        ?>
                                
                        <?php
                                echo "<s>".$todo['task']."</s></td><td>".$todo['ordre']."</td><td>".$complete."</td><td>";
                        ?>
                                <a href="<?php echo base_url('ToDo/fait/'.$todo['id']); ?>">Fait</a>
                        <?php
                            }
                        ?>
                            
                    </td>
                    <!-- <td><input type="button" value="Modifier" onclick="<?php echo base_url('todo/modifier/'.$todo['id']); ?>"/></td>-->
                    <td><a href="<?php echo base_url('todo/modifier/'.$todo['id']); ?>">Modifier</a></td>
                    <td><a href="<?php echo base_url('todo/supprimer/'.$todo['id']); ?>">Supprimer</a></td>
                    <!-- <td><input type="button" value="Supprimer" onclick="<?php echo base_url('todo/supprimer/'); ?>"/></td> -->
                </tr>
            
            <?php endforeach; ?>
            </table>
            
            <table>
                <td><a href="<?php echo base_url('todo/ajouter/'); ?>">Ajouter</a></td>
                <td><a href="<?php echo base_url('todo/reset/'); ?>">Reset</a></td>
            </table>
        </div>
    </body>
</html>


