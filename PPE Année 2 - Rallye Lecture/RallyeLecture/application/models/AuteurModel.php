<?php

class AuteurModel extends CI_Model {
    public $ValidationRules=array(
        array('field'=>'nom','label'=>'Nom','rules'=>'required|max_length[60]')
    );

    function __construct() {
        parent::__construct();
    }

    function get_auteur($id) {
        return $this->db->get_where('auteur',array('id'=>$id))->row_array();
    }
    
    function get_count()
    {
        $count = $this->db->query('SELECT * FROM auteur');
        
        return $count->num_rows();
    }
    
    function get_all_auteurs($start = NULL, $count = NULL) {
        if(isset($start) && isset($count))
        {
            $res = $this->db->get('auteur',$count, $start)->result_array();
        }
        
        else
        {
            $res = $this->db->get('auteur')->result_array();
        }
        
        return $res;
    }

    function add_auteur($params) {
        $this->db->insert('auteur',$params);
        return $this->db->insert_id();
    }

    function update_auteur($id,$params) {
        $this->db->where('id',$id);
        $this->db->update('auteur',$params);
    }

    function delete_auteur($id) {
        $this->db->delete('auteur',array('id'=>$id));
    }

}