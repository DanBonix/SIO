<?php echo validation_errors(); ?>
<?php echo form_open_multipart('Livre/Add'); ?>
<div>Titre      : <input type="text" name="titre" value="<?php echo $this->input->post('titre'); ?>" /></div>
<div>Couverture : <input type="file" name="couverture" onchange="loadImage(event);"/></div>
<div>Auteur     : <?php $comboBoxAuteur->Render(); ?></div>
<div>Editeur    : <?php $comboBoxEditeur->Render(); ?></div>
<div>Quizz      : <?php $comboBoxQuizz->Render(); ?></div>

<img id="preview" height="100" width="100"/>
<button type="submit">Sauvegarder</button>
<?php echo form_close(); ?>

<script>
    var loadImage = function(event) 
    {
        var preview = document.getElementById('preview');
        preview.src = URL.createObjectURL(event.target.files[0]);
    }
</script>