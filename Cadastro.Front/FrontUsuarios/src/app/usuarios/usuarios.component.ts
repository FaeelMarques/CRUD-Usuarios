import { Component, OnInit } from '@angular/core';

import { UsuariosService } from '../usuarios.service'

@Component({
  selector: 'app-usuarios',
  templateUrl: './usuarios.component.html',
  styleUrls: ['./usuarios.component.css']
})
export class UsuariosComponent implements OnInit {

usuarios: Array<any> = new Array();

  constructor(private usuarioService: UsuariosService) { }

  ngOnInit(): void {

    this.listarUsuarios();
  }

  listarUsuarios(){
    this.usuarioService.listarUsuarios().subscribe(usuarios =>{
      this.usuarios = usuarios
    }, error => {
      console.log('Erro ao listar usuários!', error);
    })
  }
}
