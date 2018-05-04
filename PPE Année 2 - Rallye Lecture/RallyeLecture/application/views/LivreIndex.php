<!-- navigation -->
<div class="navigation">
    <a href="<?php echo base_url(); ?>">Home</a>
    <a href="<?php echo site_url('livre/add');?>">Ajouter</a>
    <label>Recherche par auteur : </label><input type="text" name="recherche"><a href="<?php echo base_url('livre/search/%'.$recherche.'%');?>">Rechercher</a>
</div>
<table>
    <tr>
        <td>#</td>
        <td>Titre</td>
        <!-- <td>Couverture</td> -->
        <td>Nom Auteur</td>
        <td>ID Éditeur</td>
        <td>ID Quizz</td>
        <td>Image</td>
        <td>Actions</td>
    </tr>
    <?php
    $z = 0;
    foreach ($livres as $l):
        $z++;
        if($z%2==0)
        {
            ?>
            <tr bgcolor="#228B22">
            <?php } else { ?>
            <tr bgcolor="#90EE90">
            <?php
        }
        ?>
            <td><?php echo $l['id']; ?></td>
            <td><?php echo $l['titre']; ?></td>
            <!-- <td><?php echo $l['couverture']; ?></td> -->
            <td><?php echo substr($l['nom'], 3, strlen($l['nom'])); ?></td>
            <td><?php echo $l['idEditeur']; ?></td>
            <td><?php echo $l['idQuizz']; ?></td>
            <td><img src="<?php echo base_url('img/'.$l['couverture']) ?>" alt="<?php echo $l['titre']; ?>" height="50" width="50"> </td>
            <td>
                <a href="<?php echo site_url('livre/edit/'.$l['id']); ?>">Edit</a> | 
                <a href="<?php echo site_url('livre/remove/'.$l['id']); ?>">Delete</a>
            </td>
        </tr>
    <?php endforeach; ?>
</table><br>
        <?php echo "Il y a ".$count." livres dans l'école"; ?><br />
        <?php echo $links; ?>