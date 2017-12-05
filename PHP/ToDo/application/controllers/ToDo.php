<?php

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 * Description of ToDo
 *
 * @property ToDoModel $toDoModel
 * 
 * @author adminSio
 */
class ToDo extends CI_Controller
{
    public function __construct()
    {
        parent::__construct();
        $this->load->model('ToDoModel');
        $this->load->helper('url', 'form');
        $this->load->library('form_validation');
    }
    
    public function index()
    {
        // 1.Charger les données
        $all_todos = $this->ToDoModel->get_all();
        // 2.Préparer les données pour la vue
        $data = array();
        $data['title'] = 'Liste de mes travaux';
        $data['todos'] = $all_todos;
        // 3.Générer la vue
        $this->load->view('ToDoIndex',$data);
    }
    
    public function fait($id)
    {
        $params = array('completed' => 1);
        
        $this->ToDoModel->update($id, $params);
        
        Redirect(base_url('ToDo/index'));
    }
    
    public function ajouter()
    {
        $data = array();
        $data['title'] = 'Ajouter une tâche';
        
        $this->form_validation->set_rules('ordre', 'ordre', 'required|numeric');
        $this->form_validation->set_rules('task', 'tâche', 'required|max_length[60]');
        
        if($this->form_validation->run() == TRUE)
        {
            $task = $this->input->post('task');
            $ordre = $this->input->post('ordre');
            
            $params = array('task' => $task, 'ordre' => $ordre, 'completed' => 0);
            
            $this->ToDoModel->add($params);
        
            Redirect(base_url('ToDo/index'));
        }
       
        else
        {
            $this->load->view('ToDoAdd');
        }
    }
    
    public function modifier($id)
    {
        $data = array();
        $data['title'] = 'Modifier une tâche';
        
        $this->form_validation->set_rules('ordre', 'ordre', 'required|numeric');
        $this->form_validation->set_rules('task', 'tâche', 'required|max_length[60]');
    
        if($this->form_validation->run() == TRUE)
        {
            $ordre = $this->input->post('ordre');
            $task = $this->input->post('task');
            
            $params = array('task' => $task, 'ordre' => $ordre, 'completed' => 0);
        
            $this->ToDoModel->update($id,$params);
            
            Redirect(base_url('ToDo/index'));
        }
        
        else
        {
            $ligne = $this->ToDoModel->get_By_Id($id);
            $data = array();
            $data['task'] = $ligne['task'];
            $data['ordre'] = $ligne['ordre'];
            $data['id'] = $id;
            
            $this->load->view('ToDoUpdate',$data);
        }
    }
    
    public function supprimer($id)
    {
            $this->ToDoModel->delete($id);
            
            Redirect(base_url('ToDo/index'));
    }
    
    public function reset()
    {
        $all_todos = $this->ToDoModel->get_all();
        $data = array();
        $data['todos'] = $all_todos;
        $params = array('completed' => 0);
        
        foreach($all_todos as $todo)
        {
            $this->ToDoModel->update($todo['id'], $params);
        }
        
        Redirect(base_url('ToDo/index'));
    }
}