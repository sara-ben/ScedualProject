import { Component, OnInit } from '@angular/core';
import { Constrains } from 'src/app/Classes/Constrains';
import { Day } from 'src/app/Classes/Day';
import { Houer } from 'src/app/Classes/Houer';
import { ResultTbl } from 'src/app/Classes/Result';
import { Teacher } from 'src/app/Classes/Teacher';
import { ConstrainsService } from 'src/app/Services/constrains.service';
import { DayService } from 'src/app/Services/day.service';
import { HourService } from 'src/app/Services/hour.service';
import { ResultService } from 'src/app/Services/result.service';
import { TeacherService } from 'src/app/Services/teacher.service';

@Component({
  selector: 'app-all-constrains',
  templateUrl: './all-constrains.component.html',
  styleUrls: ['./all-constrains.component.css']
})
export class AllConstrainsComponent implements OnInit {

  constructor(
    private constrainsService: ConstrainsService,
    private teacherService: TeacherService,
    private dayService: DayService,
    private hourService: HourService,
    private resultService: ResultService) { }

allConstrains: Array<Constrains>= new Array<Constrains>();
allTeachers: Array<Teacher>= new Array<Teacher>();
selectedTeacherId: number | undefined;
allDays: Array<Day> = new Array<Day>();
allHouers: Array<Houer> = new Array<Houer>();
allResults: Array<ResultTbl> = new Array<ResultTbl>();
consrainsPerTeacher: Array<Constrains> =new Array<Constrains>();
  ngOnInit(): void {
    this.allDays=this.dayService.dayList;
    this.allHouers=this.hourService.houerList;
  this.dayService.getAllDays().subscribe(data => {
      this.allDays = data;
      this.hourService.getAllHouer().subscribe(data => {
        this.allHouers = data;
    this.constrainsService.getAllallConstrains().subscribe(data => {
      this.allConstrains = data;
      this.sortAllHouers()

      this.teacherService.getAllTeacher().subscribe(data => {
        this.allTeachers = data;
       
      })
    })
  })
})
  }

//פונקציה שמוצאת את כל האילוצים של המורה
getConsransPerTeacher(){
  this.consrainsPerTeacher=this.allConstrains.filter(c=> c.idTeacher==this.selectedTeacherId)
}
//פונקציה שבודקת עבור כל תוצאה האם - למורה יש אילוץ בזמן הזה או לא
chekDay( dayId: number, hourId: number){
   var x= this.consrainsPerTeacher.filter(c=>c.idDay==dayId && c.idHour==hourId);
   if(x.length) 
  return 1;
  return 0;
}

sortAllHouers(){
  //numSort לסדר את המערך של השעות לפי ;
      this.allHouers.sort(function(a, b){return a.numSort-b.numSort});
    }

}
