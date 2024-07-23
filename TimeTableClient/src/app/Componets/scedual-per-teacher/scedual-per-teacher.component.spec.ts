import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ScedualPerTeacherComponent } from './scedual-per-teacher.component';

describe('ScedualPerTeacherComponent', () => {
  let component: ScedualPerTeacherComponent;
  let fixture: ComponentFixture<ScedualPerTeacherComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ScedualPerTeacherComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ScedualPerTeacherComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
