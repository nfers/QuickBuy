import { AppComponent } from './../../app.component';
import { Component } from '@angular/core';
import { User } from 'src/app/models/user.model';

@Component({
    selector: "app-login",
    templateUrl: './login.component.html',
     styleUrls: ['./login.component.css']
})

export class LoginComponent {
    public user;
    usuarioAutenticado: boolean;

    constructor() {
        this.user = new User();
    };
       
    entrar() {
        if (this.user.email == "ncy.fers@gmail.com" && this.user.password == "123456") {
            this.usuarioAutenticado = true;
        }
        else (this.usuarioAutenticado = false);
     alert(this.usuarioAutenticado.valueOf());    
    };    

};