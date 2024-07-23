import { Component, OnInit } from '@angular/core';
import { Day } from 'src/app/Classes/Day';
import { Grade } from 'src/app/Classes/Grade';
import { Houer } from 'src/app/Classes/Houer';
import { Lesson } from 'src/app/Classes/Lesson';
import { ResultTbl } from 'src/app/Classes/Result';
import { Teacher } from 'src/app/Classes/Teacher';
import { DayService } from 'src/app/Services/day.service';
import { GradeService } from 'src/app/Services/grade.service';
import { HourService } from 'src/app/Services/hour.service';
import { LessonService } from 'src/app/Services/lesson.service';
import { ResultService } from 'src/app/Services/result.service';
import { TeacherService } from 'src/app/Services/teacher.service';

@Component({
  selector: 'app-scedual-per-teacher',
  templateUrl: './scedual-per-teacher.component.html',
  styleUrls: ['./scedual-per-teacher.component.css']
})
export class ScedualPerTeacherComponent implements OnInit {

  constructor( 
    private teacherService: TeacherService,
    private dayService: DayService,
    private hourService: HourService,
    private gradeService: GradeService,
    private resultService: ResultService,
    private lessonService: LessonService) { }

    allTeachers: Array<Teacher>= new Array<Teacher>();
    idSelectedTeacher: number | undefined;
    allDays: Array<Day> = new Array<Day>();
    allHouers: Array<Houer> = new Array<Houer>();
     allGrade: Array<Grade> = new Array<Grade>();
     schedualPerTeacher: Array<ResultTbl>= new Array<ResultTbl>();
     allResults: Array<ResultTbl> = new Array<ResultTbl>();
    allLesons:Array<Lesson> = new Array<Lesson>();
    lesson: Lesson | undefined;
  ngOnInit(): void {

    
    this.dayService.getAllDays().subscribe(data => {
      this.allDays = data;
      this.hourService.getAllHouer().subscribe(data => {
        this.allHouers = data;
        this.sortAllHouers()
        
      this.teacherService.getAllTeacher().subscribe(data => {
        this.allTeachers = data;
        
      this.gradeService.getAllGrade().subscribe(data => {
        this.allGrade = data;

        this.resultService.getAllResult().subscribe(data => {
          this.allResults = data;

          this.lessonService.getAllLessons().subscribe(data => {
            this.allLesons = data;
          })

        })
      })
      })
    })
  })

  }

  //פונקציה שמחזירה את כל השערים שהמורה מלמדת בהם
  getResultPerTeacher(){
this.schedualPerTeacher=this.allResults.filter(r=>r.idTeacher==this.idSelectedTeacher);
  }
  sortAllHouers(){
    //numSort לסדר את המערך של השעות לפי ;
        this.allHouers.sort(function(a, b){return a.numSort-b.numSort});
      }
  //פונקציה שבודקת האם המורה מלמדת בזמן הזה
  chekResult(dayId: number, hourId: number){

   var l=this.allLesons.filter(l=>l.idDay==dayId && l.idHour==hourId);
    var x= this.schedualPerTeacher.filter(r=>r.idLesson==l[0].id);
    if(x.length) 
   return this.allGrade[x[0].idGrade].name;
   return "--";
  }


}
