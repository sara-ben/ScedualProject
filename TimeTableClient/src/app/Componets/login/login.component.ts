import { Component, OnInit } from '@angular/core';
import { UserService } from 'src/app/Services/user.service';
import { FormBuilder, FormControl, Validators, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  connect = true;
  userList: any;
  loginForm!: FormGroup;
  flag2 = false;
  hide = true;

  constructor(private userService: UserService, private fb: FormBuilder, private router: Router) {

  }

  ngOnInit(): void {
    this.loginForm = this.fb.group({

      'userName': new FormControl('', Validators.required),
      'userPassword': new FormControl('', Validators.required),
    })


    this.userService.getAllUsers().subscribe((data: any) => {
      this.userList = data;

    });

  }

  onSubmit(): void { this.userService.login() }

  openRegister() {
    this.connect = false

  }
  toSignIn() {
    this.connect = true
  }
  login() {

    for (var i = 0; i < this.userList.length; i++) {
      if (
        this.userList[i].name == this.loginForm.value.userName &&
        this.userList[i].password == this.loginForm.value.userPassword
      ) {
        localStorage.setItem('user', this.userList[i].name);
        this.router.navigate(['home']);
        return;
      }
    }

    Swal.fire("שם משתמש או סיסמה לא תקינים ", "אם אין לך משתמש הרשמי כעת", "error");
  }
}