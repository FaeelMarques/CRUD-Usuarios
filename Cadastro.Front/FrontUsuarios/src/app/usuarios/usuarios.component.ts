import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';  
import { UsuariosService } from '../usuarios.service'
import { Usuario } from '../usuario';

@Component({
  selector: 'app-usuarios',
  templateUrl: './usuarios.component.html',
  styleUrls: ['./usuarios.component.css']
})
export class UsuariosComponent implements OnInit {

 usuarios: Usuario[] ;

  constructor(private usuarioService: UsuariosService) { }

  ngOnInit(): void {

    this.listarUsuarios();
  }

  listarUsuarios(){
    // this.usuarios = this.usuarioService.listarUsuarios();  
    this.usuarioService.listarUsuarios().subscribe(usuarios =>{
      this.usuarios = usuarios,
      console.log(usuarios);
    }, error => {
      console.log('Erro ao listar usuários!', error);
    })
  }
}
