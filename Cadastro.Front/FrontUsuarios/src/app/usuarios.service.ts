import { Injectable } from '@angular/core';
import { HttpHeaders } from '@angular/common/http';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs';
import { Usuario } from './usuario'

var httpOptions = {headers: new HttpHeaders({"Content-Type": "application/json"})};

@Injectable({
  providedIn: 'root'
})
export class UsuariosService {

  constructor(private http: HttpClient) { }

  listaUsuarios(): Observable<Usuario[]>{
    return this.http.get<Usuario[]>("http://localhost:55088/usuario/");
  }
  
  cadastrarUsuario(usuario: Usuario): Observable<Usuario>{
    return this.http.post<Usuario>("http://localhost:55088/usuario/", usuario, httpOptions);
  }
  
  atualizarUsuario(usuario: Usuario): Observable<Usuario>{
    return this.http.put<Usuario>("http://localhost:55088/usuario/", usuario , httpOptions);
  }
  
  removerUsuario(id: any) :Observable<number>{
    return this.http.delete<number>("http://localhost:55088/usuario/".concat(id), httpOptions);
  }

  BuscaUsuarioById(id: any) :Observable<Usuario>{
    return this.http.get<Usuario>("http://localhost:55088/usuario/".concat(id), httpOptions);
  }
}
