<?php

/**  @property AuteurModel $hasOneAuteur 
 *   @property Editeurmodel $hasOneEditeur 
 *   @property Quizzmodel $hasOneQuizz 
 */
class LivreModel extends CI_Model {
    public $ValidationRules=array(
        array('field'=>'titre','label'=>'Titre','rules'=>'required|max_length[45]'),
        array('field'=>'couverture','label'=>'Couverture','rules'=>'max_length[100]'),
        array('field'=>'idAuteur','label'=>'idAuteur','rules'=>'required|integer'),
        array('field'=>'idEditeur','label'=>'idEditeur','rules'=>'required|integer'),
        array('field'=>'idQuizz','label'=>'idQuizz','rules'=>'integer')
    );

    function __construct() {
        parent::__construct();
        $this->load->model('auteurModel','hasOneAuteur');
        $this->load->model('editeurModel','hasOneEditeur');
        $this->load->model('quizzModel','hasOneQuizz');
    }

    function get_livre($id) {
        return $this->db->get_where('livre',array('id'=>$id))->row_array();
    }
    
    function get_count()
    {
        $count = $this->db->query('SELECT * FROM livre');
        
        return $count->num_rows();
    }
    
    function get_all_livres($start = NULL, $count = NULL) {
        if(isset($start) && isset($count))
        {
            $this->db->join('auteur', 'livre.idAuteur = auteur.id');
            $res = $this->db->get('livre',$count, $start)->result_array();
        }
        
        else
        {
            $res = $this->db->get()->result_array();
        }
        
        return $res;
    }

    function add_livre($params) {
        $this->db->insert('livre',$params);
        
        return $this->db->insert_id();
    }

    function update_livre($id,$params) {
        $this->db->where('id',$id);
        $this->db->update('livre',$params);
    }

    function delete_livre($id) {
        $this->db->delete('livre',array('id'=>$id));
    }
    
    function search_livre()
    {
        $recherche = $this->input->post('recherche');
        
        $query = $this->db->like('titre','%$recherche%');
        
        $res = $this->db->get('livre')->result_array();
        
        return $res;
    }

    function get_auteur($id) {
        $this->db->select('idAuteur, nom');
        $this->db->from('livre');
        $this->db->join('auteur', 'idAuteur = id');
        $nom=$this->db->get_where('livre',array('id'=>$id))->row_array()['nom'];
        
        return $this->hasOneAuteur->get_auteur($nom);
    }

    function get_editeur($id) {
        $idEditeur=$this->db->get_where('livre',array('id'=>$id))->row_array()['idEditeur'];
        return $this->hasOneEditeur->get_editeur($idEditeur);
    }

    function get_quizz($id) {
        $idQuizz=$this->db->get_where('livre',array('id'=>$id))->row_array()['idQuizz'];
        return $this->hasOneQuizz->get_quizz($idQuizz);
    }
}