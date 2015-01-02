#include "DigitalClock.h"
#include "ClockTimer.h"

DigitalClock::DigitalClock(ClockTimer *s)
	:Widget(this)
{
	_subject = s;
	_subject->Attach(this);
}

DigitalClock::~DigitalClock()
{
	_subject->Detach(this);
}

void DigitalClock::Update(Subject *theChangedSubject)
{
	if (theChangedSubject == _subject)
	{
		Draw();
	}
}

void DigitalClock::Draw()
{
	int hour = _subject->GetHour();
	int minute = _subject->GetMinute();
	int second = _subject->GetSecond();

	// Draw the digital clock
}