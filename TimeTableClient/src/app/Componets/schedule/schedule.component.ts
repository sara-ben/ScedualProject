import { Component, OnInit } from '@angular/core';
import { Day } from 'src/app/Classes/Day';
import { Grade } from 'src/app/Classes/Grade';
import { Houer } from 'src/app/Classes/Houer';
import { Lesson } from 'src/app/Classes/Lesson';
import { ResultTbl } from 'src/app/Classes/Result';
import { Teacher } from 'src/app/Classes/Teacher';
import { Subject } from 'src/app/Classes/Subject';
import { DayService } from 'src/app/Services/day.service';
import { GradeService } from 'src/app/Services/grade.service';
import { HourService } from 'src/app/Services/hour.service';
import { LessonService } from 'src/app/Services/lesson.service';
import { ResultService } from 'src/app/Services/result.service';
import { SubjectService } from 'src/app/Services/subject.service';
import { TeacherService } from 'src/app/Services/teacher.service';

@Component({
  selector: 'app-schedule',
  templateUrl: './schedule.component.html',
  styleUrls: ['./schedule.component.css']
})
export class ScheduleComponent implements OnInit {

  constructor(private gradeService:GradeService,
    private dayService: DayService,
    private hourService: HourService,
    private resultService: ResultService,
    private teacherService: TeacherService,
    private lessonService: LessonService,
    private subjectService: SubjectService) { }

  allGrades: Array<Grade>=new Array<Grade>;
  allDays: Array<Day>=new Array<Day>;
  allHouers: Array<Houer>=new Array<Houer>;
  allResults: Array<ResultTbl>=new Array<ResultTbl>;
  selectedGradeName: string | undefined;
  selectedGrade: Grade | undefined;
  scedualPerGrade: Array<ResultTbl>=new Array<ResultTbl>;
  allTeachers: Array<Teacher> = new Array<Teacher>();
  allLessons: Array<Lesson> = new Array<Lesson>();
  allSubjects: Array<Subject> = new Array<Subject>;
  isScedualPerGradeSorted: boolean = false;
  i:number = 0;
  ngOnInit(): void {
    this.gradeService.getAllGrade().subscribe(data => {
      this.allGrades = data;
      this.gradeService.gradeList=data;
      this.dayService.getAllDays().subscribe(data => {
        this.allDays = data;
        this.dayService.dayList=data;
        this.hourService.getAllHouer().subscribe(data => {
            this.allHouers = data;
            this.hourService.houerList=data;
            // this.addHouerIdToResultModel()
            this.resultService.getAllResult().subscribe(data => {
                this.allResults = data;
                this.resultService.resultList=data;
                this.teacherService.getAllTeacher().subscribe(data => {
                  this.allTeachers = data;
                  this.teacherService.teacherList= data;
                  this.lessonService.getAllLessons().subscribe(data => {
                  this.allLessons = data;
                  this.lessonService.lessonList=data;
                  this.subjectService.getAllSubject().subscribe(data => {
                    this.allSubjects = data;
                    console.log("all subjects",this.allSubjects)
                  // this.constrainsService.getAllallConstrains().subscribe(data => {
                  //   tגןhis.allConstrains = data;
                  //   console.log(this.allConstrains);
                    this.teacherService.getAllTeacher().subscribe(data => {
                      this.allTeachers = data;
                      console.log(this.allTeachers);

                     
                    })
                  })
                  this.getTeacherNameByResults();
                  this.addHouerIdToResultModel();
                  this.addDayIdToResultModel();
                },);
                },);
              },);
                },);
              // },);
            
          },);
        
      },);

  }
  sortAllHouers(){
//numSort לסדר את המערך של השעות לפי ;
    this.allHouers.sort(function(a, b){return a.numSort-b.numSort});
    console.log("all houers sorted",this.allHouers)
  }

  sortScedualPerGrade(){
    this.scedualPerGrade.sort(function(a, b){return (a.dayId-b.dayId || a.numSortHouer-b.numSortHouer)});
    console.log("all scedualPerGrade sorted 1 lavel",this.scedualPerGrade);
    this.isScedualPerGradeSorted=true;

    // this.scedualPerGrade.sort(function(a, b){return (a.numSortHouer-b.numSortHouer)}) ;
  }

  getSchedulePerClass(){
    //מציאת הכיתה שנבחרה
    this.sortAllHouers()
    //ריקון המערך מפעם הקודמת
    this.scedualPerGrade=new Array<ResultTbl>()
    this.isScedualPerGradeSorted=false;

    this.allGrades.forEach(item => {
  if(item.name==this.selectedGradeName)
  {
    this.selectedGrade=item;
    console.log(item);
    this.gradeService.selectedGrade=item;
  }
})


//מציאת כל השעורים של הכיתה שנבחרה
    this.allResults.forEach(item=>{
      if(item.idGrade==this.selectedGrade?.id)
          {
            this.scedualPerGrade.push(item)
          }
    })

console.log("scedualPerGrade",this.scedualPerGrade)
console.log("allHouers",this.allHouers)
//להציג את המערכת של כל הימים וכל השעות 

this.addNumSortHouuerToResultModel();

this.sortScedualPerGrade();
  }

  getTeacherNameByResults(){
    //כאן עברתי על כל השיעורים והוספתי להם את השם של המורה לפי ה אי די של המורה
  this.allResults.forEach(result=>{
      this.allTeachers.forEach(teacher=>{
        if(result.idTeacher==teacher.id)
        {
          result.teacherName=teacher.name;
        }
      })
  })
  }

  addDayIdToResultModel(){
    //כאן עברתי על כל התוצאות והוספתי להם אי די של יום לפי  ה אי די של שעור
  this.allResults.forEach(result=>{
      this.allLessons.forEach(lesson=>{
        if(result.idLesson==lesson.id)
        {
          result.dayId=lesson.idDay;
        }
      })
  })
  }
  addNumSortHouuerToResultModel(){
    //כאן עברתי על כל התוצאות והוספתי להם אי די של יום לפי  ה אי די של שעור
  this.scedualPerGrade.forEach(result=>{
    // result.numSort20Day=result.dayId*1000
      this.allHouers.forEach(houer=>{
        if(result.houerId==houer.id)
        {
          result.numSortHouer=houer.numSort*(result.dayId);
        }
      })
  })
  console.log("scedualPerGrade with num sort", this.scedualPerGrade)
  }
  addHouerIdToResultModel(){
    //כאן עברתי על כל התוצאות והוספתי להם אי די של יום לפי  ה אי די של שעור
  this.allResults.forEach(result=>{
      this.allLessons.forEach(lesson=>{
        if(result.idLesson==lesson.id)
        {
          result.houerId=lesson.idHour;
          
        }
      })
  })
  }
  
  chekResult(dayId: number, hourId: number){

    // var l=this.allLessons.filter(l=>l.idDay==dayId && l.idHour==hourId);
     var x= this.scedualPerGrade.filter(l=>l.dayId==dayId && l.houerId==hourId);
    //  console.log("x",x);
     if(x.length) 
    return this.allSubjects[x[0].idSubject-1].name;
    return "--";
   }

}


