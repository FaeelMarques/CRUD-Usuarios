import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';  
import { UsuariosService } from '../usuarios.service'
import { FormBuilder, Validators } from '@angular/forms'; 
import { Usuario } from '../usuario';

@Component({
  selector: 'app-usuarios',
  templateUrl: './usuarios.component.html',
  styleUrls: ['./usuarios.component.css']
})
export class UsuariosComponent implements OnInit {

 usuario : Usuario = new Usuario(); 
 listaUsuarios: Observable<Usuario[]>;
 

  constructor(private usuarioService: UsuariosService) { }

  ngOnInit(): void {
    this.listarUsuarios();
  }

  listarUsuarios(){
    this.listaUsuarios = this.usuarioService.listaUsuarios();
  }

  cadastrarUsuario(){
    this.usuarioService.cadastrarUsuario(this.usuario).subscribe(() => {
      this.usuario = new Usuario();
      this.listarUsuarios();
        }, error => {
      console.log('Erro ao cadastrar usuário!', error);
    })
  }

  editarUsuario(id: number){
    this.usuario.Id = id;
    this.usuarioService.atualizarUsuario(this.usuario).subscribe(() => {
      this.usuario = new Usuario();
      this.listarUsuarios();
        }, error => {
      console.log('Erro ao atualizar dados do usuário!', error);
    })
    
  }

  removerUsuario(id: number){
    this.usuarioService.removerUsuario(id).subscribe(() => {
      this.listarUsuarios();
        }, error => {
      console.log('Erro ao remover o usuário!', error);
    })
  }
}
