import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, FormControl, Validators, ValidatorFn, ValidationErrors } from '@angular/forms';
import { Router } from '@angular/router';
import { UserService } from 'src/app/Services/user.service';
import Swal from 'sweetalert2';


@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  registerForm!: FormGroup;
  userList: any;
  flag!: boolean;
  hide = true;

  constructor(private fb: FormBuilder, private userService: UserService, private router: Router) {
    
   }

  ngOnInit(): void {
    this.registerForm = this.fb.group({

      'Name': new FormControl('', Validators.required),
      'Password': new FormControl('', Validators.required),
      'userPassword1': new FormControl('', [Validators.required, this.chek()])
    });
    this.userService.getAllUsers().subscribe((data) => {
      this.userList = data;
    })
  }
  getErrorPassword() {

    if (this.registerForm.get('userPassword1')?.value == "")
      return 'שדה זה חובה';
    else if (this.registerForm.get('userPassword1')?.hasError('noMatch'))
      return 'סיסמאות לא תואמות'
      return null;

  }
  
  get userPassword1() {
    return this.registerForm.get('userPassword1');
  }
  register() {
    for (var i = 0; i < this.userList.length; i++) {
      if (this.userList[i].name == this.registerForm.value.Name)
        this.flag = false;
    }
    // לוגיקה של הוספת משתמש
    this.userService.registerUser(this.registerForm.value).subscribe((user) => {
      if(user) {
        Swal.fire('ההרשמה בוצעה בהצלחה!', '', 'success');
        localStorage.setItem('user', this.registerForm.value.Name);
        this.router.navigate(['home']);
      }
      else
        Swal.fire('אירעה שגיאה בעת ההרשמה', '', 'error');
    })
  }

  chek(): ValidatorFn {
    return (control: AbstractControl): ValidationErrors | null => {
      let valid = true;
       if (control.value !== this.registerForm?.get("Password")?.value) {
        valid = false;
      }
      return valid ? null : { noMatch: true }
    };
  }
}