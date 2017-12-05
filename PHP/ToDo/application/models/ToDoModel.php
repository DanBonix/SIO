<?php
    if(! defined('BASEPATH')) 
        exit ('No direct script access allowed');
/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 * Description of ToDoModel
 * 
 * @property CI_DB db
 *
 * @author adminSio
 */
class ToDoModel extends CI_Model
{
    function __construct()
    {
        parent::__construct();
    }
    
    function get_By_Id($id)
    {
        return $this -> db -> get_where('todo',array('id'=>$id))->row_array();
    }
    
    function get_all()
    {
        $this->db->order_by('id', 'ASC');
        return $this -> db -> get('todo') -> result_array();
    }
    
    function get_Last_Id()
    {
        $this->db->select('MAX(id)');
        $this->db->from('todo');
        $query = $this->db->get('todo')->result_array();
        
        return $query;
    }
    
    function add($params)
    {
        $this->db->insert('todo',$params);
    }
    
    function update($id,$params)
    {
        $this->db->where('id',$id);
        $this->db->update('todo',$params);
    }
    
    function delete($id)
    {
        $this->db->delete('todo', array('id'=>$id));
    }
}