import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AllConstrainsComponent } from './all-constrains.component';

describe('AllConstrainsComponent', () => {
  let component: AllConstrainsComponent;
  let fixture: ComponentFixture<AllConstrainsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AllConstrainsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AllConstrainsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
