Archive of Rawr taken from https://codeplexarchive.org/project/Rawr

Use at your own risk.

All rights belong to the original developers.

4.3 folder contains Rawr 4.3.8

Prereq to compile Rawr 4.3.8:
- Visual Studio 2015 (VS 2017 might work, but I've only tried VS 2015. VS 2022 will NOT work.)
- Visual Studio 2010
- Visual Studio 2010 Service Pack 1
- WPF (https://codeplexarchive.org/project/wpf)

Patch notes from 4.3.5 onwards:

Rawr 4.3.8

Rawr.Base:
- Workaround for item availability filtering.
- Change dwarf racial from armor multiplier to damage reduction multiplier.
- Fixes to printing.
- Added US-Gallywix server to the server list.
Rawr.ProtPaladin:
- Fix stat display calculations.
- Fix the issue where going over the block cap completely wrecked defensive stat values.
- Implement an EffectiveBlock property.
- Partial fix to relevancy methods to show relevant set bonuses.
- Implement 2T13 set bonus.
- Absorbs are applied after damage reduction multipliers, instead of getting multiplied through.
- Separate always-up special effects from proc special effects and apply them to the calculations.
- Fix display values to show static combat table values, including always-up special effects.
- Incorporate paladin tank cooldowns and Avenging Wrath in special effects.
- Fix 2T12 set bonus.
Rawr.Enhance:
- Small changes for the display
- First go at counting damage procs. Still needs some work
Rawr.Mage:
- Fix for int stacking effects in genetic solver.
Rawr.Moonkin:
- Comprehensive rebuild of moonkin simulator.

Rawr 4.3.7

Rawr.Base.Items:
- All Dragon Soul Plate Tanking Socket Bonuses have been fixed
- Removed unnessasary Unique IDs from Fireland Rep trinkets
- Updated with missing Dodge, Parry, and Expertise socket bonus values
Rawr.Enhance:
- Fix for trinkets being badly valued (sans trinkets that proc damage)
- Minor fix for export to enhsim
- Tweak to Windfury calcs
Rawr.Mage:
- Updating Fireball/Pyroblast coefficients for 4.3.2.
- Fix for elixir and flask chart.
- Fix for aoe mode with cycle level procs.
Rawr.Moonkin:
- Major fixes to DoT calculations in the simulator:
- Slight change to the calculation of NG DoT tick rate in the simulator.
- DoTs implement proper refresh behavior, instead of clipping.
- Shooting Stars procs properly calculated.
- Use exact representation of DoT ticks when checking if a refresh is needed, instead of rounding to the nearest tick.
This doesn't completely solve the haste problem, but the distribution tables should be more accurate.

Rawr 4.3.6

Rawr.Enhance:
- SP is now correctly set to 55% of AP
- Further tweaks to Export to EnhSim
Rawr.DPSDK:
- Fix for 21931 - Gargoyle damage was not actually related to Summon Gargoyle talent like it should be.
- Fix for 21932: Unholy Frenzy wasn't modeled.
- 21930: SS was not properly taking into account Bonus damage from mastery for it's shadow component.
Rawr.Mage:
- Improved fire cycle models.
- Combustion policy optimization tool (using idealized ignite model currently, still need to add the free tick model).
Rawr.ProtPaladin:
- Remove the behavior where a negative chance to be crit was reducing the average damage per hit/attack, which was causing mastery to be way overvalued even past the block cap.
- Fix the combat table so that entries below block are properly adjusted.
- Reduce Holy Shield static %BV to 6.67% from 10% to match the new Holy Shield mechanic.
- Change the %BV meta gem to be applied as a multiplier.
- Add explanatory tooltips to the character stats tab to help explain differences in display between Rawr and live.
Rawr.Moonkin:
- Add caster crit chance to trinket procs.
- Fix a bug with the Variable Pulse Lightning Capacitor that was double-counting its proc.
- Greatly increase the resolution of the simulator data.
- Correct the simulator's DoT casting behavior to match SimulationCraft.
- 4T12: Properly implement Shooting Stars in the simulator so that the buff can run out before Eclipse is reached.
- Glyph of Starfire: Increase the level of detail in the spell distribution tables to be able to properly calculate GoSF damage.
- 4T12: Set bonus now modifies the displayed average energy for Wrath and Starfire.
- Add additional precision to the displayed energy for nukes.
- Fix broken Glyph of Starfire calculations in the simulator.
- Minor adjustment to Glyph of Starfire implementation to improve accuracy.

Rawr 4.3.5

Rawr.Base:
- Changed server name from Aggra to Aggra-Portugues to work with Blizzard's API.
- Adding Nozdormu's Presence temporary buff.
Rawr.Items:
- Updated all 3 Timepiece of the Bronze Flight's with a gem socket that Blizzard hot fixed
- Kiril, Fury of Beasts was hotfixed with undocumented Bonus Armor
- Corrected Bracers of Flowing Serenity to included the 20 Int gem socket that was hotfixed
- Added both Pit Fighter trinkets
- Support for special effect damage procs modified by spell power and attack power.
- Updated Item Cache with Cunning, Vial, and Bone-Link SP/AP Scaling
- Fixed Rathrak, the Poisonous Mind (LFR 390) not having a Mage Restriction associated with it.
- Gurthalak now procs 10 times over 12 secs; up from 8 times over 10 seconds.
Rawr.Enhance:
- Add export for T13 set bonus's
- Fix for incorrect AP/SP values
Rawr.Cat:
- Added support for AP Scaling
Rawr.Bear:
- Added support for AP Scaling
Rawr.Mage:
- Changing effect procs to 2x crit multiplier, support for spell power modified damage procs.
Rawr.Moonkin:
- Support proc effects that benefit from spell power scaling.
- 4.3.2 PTR: 4T13 set bonus now also increases Starsurge damage by 10%.
