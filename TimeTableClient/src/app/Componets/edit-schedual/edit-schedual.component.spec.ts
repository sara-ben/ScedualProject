import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditSchedualComponent } from './edit-schedual.component';

describe('EditSchedualComponent', () => {
  let component: EditSchedualComponent;
  let fixture: ComponentFixture<EditSchedualComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EditSchedualComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EditSchedualComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
