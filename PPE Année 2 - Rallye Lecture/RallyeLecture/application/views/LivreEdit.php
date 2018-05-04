<?php echo validation_errors(); ?>
<?php echo form_open('livre/edit/'.$livre['id']); ?>
<div>Titre      : <input type="text" name="titre" value="<?php echo ($this->input->post('titre') ? $this->input->post('titre') : $livre['titre']); ?>" /></div>
<div>Couverture : <input type="file" name="couverture" onchange="refreshImage(event);"/></div>
<div>Auteur     : <?php $comboBoxAuteur->Render(); ?></div>
<div>Editeur    : <?php $comboBoxEditeur->Render(); ?></div>
<div>Quizz      : <?php $comboBoxQuizz->Render(); ?></div>
<div><img src="<?php echo base_url('img/'.($this->input->post('couverture') ? $this->input->post('couverture') : $livre['couverture'] )) ?>" alt="<?php echo ($this->input->post('titre') ? $this->input->post('titre') : $livre['titre']); ?>" height="100" width="100"> </div>
<button type="submit">Sauvegarder</button>
<?php echo form_close(); ?>

<script>
    var refreshImage = function(event) 
    {
        var preview = document.getElementById('preview');
        preview.src = URL.createObjectURL(event.target.files[0]);
    }
</script>