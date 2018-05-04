<?php echo validation_errors(); ?>
<?php echo form_open('Niveau/Add'); ?>
<div>Niveau scolaire : <input type="text" name="niveauScolaire" value="<?php echo $this->input->post('niveauScolaire'); ?>" /></div>
<button type="submit">Save</button>
<?php echo form_close(); ?>