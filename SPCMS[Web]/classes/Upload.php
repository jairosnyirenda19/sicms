<?php

/**
 * 
 */
class Upload
{
	private $_db,
			$_dir,
			$upload_dir,
			$errors= array(),      
			$file_name, 
			$file_size,
			$file_tmp,
			$file_type,
			$file_ext,
			$extensions= array("jpeg","jpg","png");

	function __construct()
	{
		$this->_dir = Config::get('dir/img_dir');
		$this->_db = DB::getInstance();
	}

	public function upload($dir, $table, $col, $id_col , $id ,$file)
	{      
		$this->file_name = basename($_FILES[$file]['name']);      
		$this->file_size = $_FILES[$file]['size'];      
		$this->file_tmp = $_FILES[$file]['tmp_name'];      
		$this->file_type = $_FILES[$file]['type'];   
		$tmp = explode('.',$this->file_name); 
		$this->file_ext = strtolower(end($tmp));            
		$this->extensions = array("jpeg","jpg","png");

		$img_path = $this->_dir.$dir.$_FILES[$file]['name'];

		if(in_array($this->file_ext, $this->extensions) === false)
		{         
			$this->errors[] = "extension not allowed, please choose a JPEG or PNG file.";
		}
		if(empty($this->errors) == true)
		{   
			move_uploaded_file($this->file_tmp, $this->_dir.$dir.$this->file_name);
			$this->_db->query("UPDATE $table SET $col = '$img_path' WHERE $id_col = $id");
		}		
	}

	public function delete(){}

	public function error()
	{
		return $this->errors;
	}

	public function file_name()
	{
		return $this->file_name;
	}

	public function file_size()
	{
		return $this->file_size;
	}

	public function file_tmp()
	{
		return $this->file_tmp;
	}

	public function file_type()
	{
		return $this->file_type;
	}

	public function file_ext()
	{ 
		return $this->file_ext;
	}

	public function upload_dir()
	{ 
		return $this->upload_dir;
	}
}